# Htmx

For what is htmx please check their [doc](https://htmx.org/), here in Fun.Blazor we use it for pull down blazor content by its request and inject into somewhere.

It is recommend to use it together with custom element, so we can get real time interactive with websocket which has full power of blazor when needed.

There is also a [blog](https://www.slaveoftime.fun/blog/navigation-and-form-enhancement-in-dotnet-8-blazor-is-not-enough) which is related to this topic.

## How to use


Register the components:

```fsharp
services.AddRazorComponents()
services.AddServerSideBlazor(fun options -> 
	// for using html.customElement
	options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly()))
services.AddFunBlazorServer()

...
app.MapRazorComponents()
app.MapRazorComponentsForSSR(Assembly.GetExecutingAssembly(), enableAntiforgery = true)
app.MapCustomElementsForSSR(Assembly.GetExecutingAssembly(), enableAntiforgery = true)
```

The simple way to serve a page

```fsharp
app.MapFunBlazor(fun _ -> html {
    head {
        ...
        CustomElement.lazyBlazorJs ()
    }
    body {
        // We can use html.customElement to prerender something and connect to server with websocket at some point
        html.customElement (
            ComponentAttrBuilder<PostLikesSurvey>().Add((fun x -> x.post_id), post.Id),
            renderAfter = RenderAfter.InViewport
        )
        // For more complex cases, we can use htmx to fetch customElement and then connect to server with websocket
        div {
            hxTrigger' hxEvt.intersect
            hxGetCustomElement (QueryBuilder<PostLikesSurvey>().Add((fun x -> x.post_id), post.Id))
            hxSwap_outerHTML
        }
        // We can also just request any blazor component as a static dom content and inject at some point based on htmx
        div {
            hxTrigger' hxEvt.intersect
            hxGetComponent (QueryBuilder<PostComment>().Add((fun x -> x.PostId), post.Id))
            hxSwap_outerHTML
        }
        // Or prerender directly and later on the PostComment itself will have htmx integration
        html.blazor (ComponentAttrBuilder<PostComment>().Add((fun x -> x.PostId), post.Id))
        // script for htmx
        script { src "https://unpkg.com/htmx.org@1.9.9" }
    }
})
```

```fsharp
[<FunBlazorCustomElement>]
type PostLikesSurvey() =
    inherit FunComponent()

    [<Parameter>]
    member val post_id = "" with get, set

    override this.Render() = fragment {
        ...
    }

type PostComment() as this =
    inherit FunComponent()

    [<Parameter>]
    member val PostId = Guid.Empty with get, set

    [<Parameter>]
    member val Comment = "" with get, set

    override _.Render() = form {
        hxSwap_outerHTML
        hxPostComponent typeof<PostComment>
        // You can use below method to save the current state in the form, so the browser will always have the latest state
        // And later you can override it, because server will only take the last value for the same key
        html.createHiddenInputs this
        html.blazor<AntiforgeryToken> ()
        textarea {
            name (nameof this.Comment)
            value this.Comment
        }
        button {
            type' InputTypes.Submit
            "Add"
        }
    }
```


