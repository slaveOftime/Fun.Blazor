## Htmx

For what is htmx please check their [doc](https://htmx.org/), here in Fun.Blazor we use it for pull down blazor content by its request and inject into somewhere.

It is recommend to use it together with custom element, so we can get real time interactive with websocket which has full power of blazor.

### How to use


Register the components:

```fsharp
services.AddRazorComponents()
services.AddServerSideBlazor(fun options -> 
	// for using html.customElement
	options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly()))
services.AddFunBlazorServer()

...
app.MapRazorComponents()
app.MapBlazorSSRComponents(Assembly.GetExecutingAssembly())
app.MapFunBlazorCustomElements(Assembly.GetExecutingAssembly())
```

The simple way to serve a page

```fsharp
app.MapFunBlazor(fun _ -> html {
    head {
        ...
        CustomElement.lazyBlazorJs ()
    }
    body {
        html.customElement (
            ComponentAttrBuilder<PostLikesSurvey>().Add((fun x -> x.post_id), post.Id.ToString()),
            renderAfter = RenderAfter.InViewport
        )
        div {
            hxTrigger' hxEvt.intersect
            hxRequestBlazorSSR (QueryBuilder<PostComment>().Add((fun x -> x.post_id), post.Id.ToString()))
            hxSwap_outerHTML
        }
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
    member val post_id = "" with get, set

    override _.Render() = fragment {
        ...
    }
```
