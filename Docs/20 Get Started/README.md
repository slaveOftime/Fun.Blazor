# Get Started

## Please check the samples for a quick start

This contains the code for the document site itself: https://github.com/slaveOftime/Fun.Blazor/tree/master/Fun.Blazor.Docs.Wasm. 

I use this to build my simple personal blogs: https://github.com/slaveOftime/Slaveoftime.Site.

This contains the code for Fun.Blazor templates, also with more samples in it: https://github.com/slaveOftime/Fun.Blazor.Samples.

## Use dotnet templates:

[![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor.Templates)](https://www.nuget.org/packages/Fun.Blazor.Templates)

```shell
dotnet new --install Fun.Blazor.Templates::2.0.0
```

With this template, you can create server/wasm blazor with [MudBlazor](https://mudblazor.com/) or [shoelacejs](https://shoelace.style/) supported.

```shell
dotnet new fb-mix -o CoolMixMode
```

## Code structure example (just my opinionated way)

This project supports multiple patterns for state management. From my experience, it is not good to use Elmish for your whole project because of the performance and state share concern. Sometimes, it is a little verbose.  

You can try this:

**Db**  
**Domain**  
**Services**  
**UI**  
|--- Stores.fs // contains shared store or global store

```fsharp
type IShareStore with // scoped for the session in blazor server mode
    member store.IsDark = store.CreateCVal("IsDark", true)

type IGlobalStore with // Singleton store, shared for all. Used in server-side blazor to share some data for all connected users.
    ...
```

|--- Hooks.fs // standalone UI logic

```fsharp
type IComponentHook with
    member hook.TryLoadPosts(page) =
        task {
            ...
        }

    member hook.UseSettingsForm() =
        hook
           .UseAdaptiveForm({| Name = "foo"; ... |})
           .AddValidators(...)
           .AddValidators(...)
```

|--- Controls.fs // Some small shared controls  
|--- Comp1.fs // Your business component  

```fsharp
// Make your fragment smaller, so you can compose it in a cleaner way and get better inline optimization, hot-reload speeding, and intellisense performance
let private fragment1 = div {...}

let private fragment2 (shareStore: IShareStore) =
    adaptiview {
        let! isDark, setIsDark = shareStore.IsDark.WithSetter()
        div { ... } 
    }

// Or use Elmish if you like
let private fragment3 = html.elmish (init, update, view)

let comp1 =
    html.inject (fun (svc1, shareStore: IShareStore, ...) ->
        div {
            childContent [
                fragment1
                fragment2 shareStore
                fragment3
            ]
        }
    )
```

|--- Comp2.Hooks.fs // in case you have a large component, or you can even create a separate folder for the whole component  
|--- Comp2.Control1.fs // manage a large control which is only for your business Comp2  
|--- Comp2.fs // The entry for your comp2  
|--- App.fs // compose your components or pages

```fsharp
let private routes =
    html.route [
        routeCi "/page1" comp1
        routeAny comp2
    ]

let app =
    div {
        header
        routes
        footer
    }
```

|--- Index.fs // if you are using blazor server mode, you need to have this. You can check the template.  
|--- Startup.fs

You can check the repo https://github.com/slaveOftime/Slaveoftime.Site as a reference for those practical tips.