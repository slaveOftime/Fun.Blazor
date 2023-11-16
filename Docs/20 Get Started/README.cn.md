# 入门指南

## 请查看示例以快速开始

这包含文档网站本身的代码：https://github.com/slaveOftime/Fun.Blazor/tree/master/Fun.Blazor.Docs.Wasm。

这包含 Fun.Blazor 模板的代码，还有更多示例：https://github.com/slaveOftime/Fun.Blazor.Samples。

## 使用 dotnet 模板：

[![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor.Templates)](https://www.nuget.org/packages/Fun.Blazor.Templates)

```shell
dotnet new --install Fun.Blazor.Templates::3.2.0
dotnet new fun-blazor -o FunBlazorDemo1
```

## 代码结构示例（只是我的意见）

> 如果你更喜欢 blazor csharp 官方风格，你可以用 fun-blazor 模板

该项目支持多个状态管理模式。根据我的经验，不推荐在整个项目中使用 Elmish，因为它会影响性能和状态共享。有时代码会有点冗长。

你可以试试这个：

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
