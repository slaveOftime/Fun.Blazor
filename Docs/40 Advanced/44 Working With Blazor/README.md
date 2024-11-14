# Working with Blazor

Using Blazor features with almost "raw" blazor elements is possible in Fun.Blazor

Most of the ways to render Blazor components in Fun.Blazor is with the `html.blazor` API it provides of several overloads you can use to render elements as required.

### Add Attributes

To add attributes to a blazor component you can use the `domAttr` builder

```fsharp
html.blazor<MyComponent> (
  domAttr {
    class' "my-component"
    "some-dalue", initialValue
  }
)
```

### Add Members

When you want to bind to particular members in a component you can do so by using the `ComponentAttrBuilder<T>()` builder, this provides a strongly typed access to the component and the properties it has exposed to bind for example:

```fsharp
html.blazor (
    ComponentAttrBuilder<MyComponent>()
        .Add((fun x -> x.Value), "Some value")
        .Add((fun x -> x.OnValueChange), EventCallback<string>(null, Action<string> (fun v -> printfn $"{v}")))
)
```

> Note: Element attributes are not the same as members, element attributes are a concept tied to HTML (e.g. class styles or inline styles), members are part of the object itself this distinction also applies to javascript in the attributes vs properties situation.

### Server/Wasm/Auto Rendering

In .NET8 a few rendering modes were added into blazor you can also use these to ensure where do you need your blazor elements to render

```fsharp
html.blazor<MyComponent>(RenderMode.InteractiveServer)

html.blazor<MyComponent>(RenderMode.InteractiveAuto)

html.blazor<MyComponent>(RenderMode.InteractiveWebAssembly)
```

For more information about what are the effects please visit the Microsoft documentation for [Blazor Rendering Modes].

## Blazor Components

If you're working with a place where there are C# and F# teams you may want to work with plain Blazor components.

Thankfully these are very simple to define as they are just a class like the following:

```fsharp
type MyComponent() =
    inherit FunComponent() // This is required

    [<Inject>]
    member val Logger: ILogger<MyComponent> = Unchecked.defaultof<_> with get, set

    [<Parameter>]
    member val Value = "" with get, set

    [<Parameter>]
    member val OnValueChangeCb: EventCallback<string> = Unchecked.defaultof<_> with get, set

    override this.Render() = div {
      $"Hello {this.Value}!"

      textarea {
          type' "text"
          value this.Value
          oninput (fun e ->
            let value = unbox<string> e.Value
            this.Logger.LogDebug("Value Changed: {OldValue} -> {NewValue}", this.Value, value)
            this.OnValueChangeCb.InvokeAsync value
          )
      }
   }
```

You can define `Parameters`, `CascadingParameters`, `EventCallbacks`, also use attributes like `Inject`, `Route`, `StreamRendering`, and most if not all of what you'd expect in your blazor components in the C# counterpart.

You can use the Fun.Blazor DSL to work with your markup and that includes dynamic content with adaptive data.

## Blazor Bindings

Sometimes you'd like to use third party libraries in Fun.Blazor you can write manual bindings or use the [Fun.Blazor.Cli] tool to generate them for you.

For the manual bindings we can use `ComponentAttrBuilder<T>()` like the following example:

```fsharp
// This is an existing component it can be defined in C# or F#
type MyComponent with

    static member create(value, onValueChanged) =
        html.blazor (
            ComponentAttrBuilder<MyComponent>()
                .Add((fun x -> x.Value), value)
                .Add((fun x -> x.OnValueChangeCb), EventCallback<string>(null, Action<string> onValueChanged))
        )
```

With our `create` extension we can now use it in a seamless way with the rest of our Fun.Blazor markup

```fsharp
module Home =
  open FSharp.Data.Adaptive
  open Fun.Blazor

  let view() =
    article {
      h1 { "This is a title" }

      adapt {
        let! value, setValue = cval("").WithSetter()

        MyComponent.create(value, setValue)

        $"the value is: {value.ToUpperInvariant()}"
      }
    }
```

This can be a tedious process however [Fun.Blazor.Cli] provides an automated tool to generate these, please visit the [Code Generation] section for more information on how to generate new bindings.

[Fun.Blazor.Cli]: ./Tooling/Code-Generation
[Code Generation]: ./Tooling/Code-Generation
[Blazor Rendering Modes]: https://learn.microsoft.com/en-us/aspnet/core/blazor/components/render-modes?view=aspnetcore-8.0
