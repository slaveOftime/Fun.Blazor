# Custom Elements

You will need to install nuget package **Fun.Blazor.CustomElements**.

For some use cases, I only want ASP.NET Core to use Fun.Blazor to pre-render static content without Blazor server connected. But for some pages or components, I want to connect to Blazor server temporarily. So I can still use Blazor and hide backend API with a single WebSocket for interaction.

It is powered by **Microsoft.AspNetCore.Components.CustomElements** which is officially supported in .NET 7.

## How to use

Register the components:

```fsharp
...
services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly()))
...
```

Set the helper script, for example you can put it at the head of your html page:

```fsharp
html {
    head {
        ...
        CustomElement.lazyBlazorJs ()
    }
    body {
        ...
    }
}
```

Define your custom component

```fsharp
[<FunBlazorCustomElement>]
type PostLikesSurvey() =
    inherit FunComponent()

    [<Parameter>]
    member val post_id = "" with get, set

    override this.Render() = fragment {
        ...
    }
```

Consume it

```fsharp
html.customElement (
    ComponentAttrBuilder<PostLikesSurvey>().Add((fun x -> x.post_id), post.Id.ToString()),
    renderAfter = RenderAfter.InViewport
)
```

## Demo

There are counters below, but shares the same `IShareStore`. So, in Blazor server mode, when you click one button, the other button will also increase automatically, which means they share the same WebSocket connection.

{{CustomElementDemo}}