# Fun.Blazor [![Nuget](https://img.shields.io/nuget/v/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine)

[WASM side docs](https://slaveoftime.github.io/Fun.Blazor/)

[Server side docs](https://funblazor.slaveoftime.fun)



## Fun.Blazor

### By default we expose Feliz style DSL

```fsharp
open Fun.Blazor
let app =
    html.div [
        attr.styles [ style.margin 10 ]
        html.text "Fun Blazor"
    ]
```

```fsharp
open Fun.Blazor.DslCE
let app =
    div(){
        styles [ style.margin 10 ]
        childContent "Fun Blazor"
    }
```

### With Fun.Blazor.Cli you can generate Feliz or CE style automatically for any blazor third party libraries

```fsharp
open Fun.Blazor
open MudBlazor

let alertDemo =
    MudCard'.create [
        MudAlert'() {
            Icon Icons.Filled.AccessAlarm
            childContent "This is the way"
        }
    ]
```

Feliz style

```fsharp
open Fun.Blazor
open MudBlazor

let alertDemo =
    mudCard.create [
        mudAlert.create [
            mudAlert.icon Icons.Filled.AccessAlarm
            mudAlert.childContent "This is the way"
        ]
    ]
```

### Create a WASM app

Other resources like index.html should be put under wwwroot. You can check Fun.Blazor.Docs.Wasm project for detail

```
dotnet add package Fun.Blazor
```

```fsharp
open System
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Fun.Blazor

let app = html.text "hello world"

let builder = WebAssemblyHostBuilder.CreateDefault(Environment.GetCommandLineArgs())
        
builder
    .AddFunBlazorNode("#app", app)
    .Services
    .AddFunBlazor() |> ignore
        
builder.Build().RunAsync() |> ignore
```

### Create a blazor server app

You can check project Fun.Blazor.Docs.Server for the actual code

```
dotnet add package Fun.Blazor
dotnet add package Bolero.Server
```

```fsharp
// Startup.fx
open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Bolero.Server
open Fun.Blazor

type Index () =
    inherit FunBlazorComponent()

    override this.Render() = html.text "Fun Blazor"

    static member page =
        html.doctypeHtml [
            html.head [
                html.title "Fun Blazor"
                html.baseUrl "/"
                html.meta [ attr.charsetUtf8 ]
                html.meta [ attr.name "viewport"; attr.content "width=device-width, initial-scale=1.0" ]
            ]
            html.body [
                attr.childContent [ html.bolero Bolero.Server.Html.rootComp<Index> ]
                html.bolero Bolero.Server.Html.boleroScript
            ]
        ]


Host.CreateDefaultBuilder(Environment.GetCommandLineArgs())
    .ConfigureWebHostDefaults(fun builder ->
        builder
            .ConfigureServices(fun (services: IServiceCollection) ->
                services.AddControllersWithViews() |> ignore
                services
                    .AddServerSideBlazor().Services
                    .AddBoleroHost(true, true)
                    .AddFunBlazor() |> ignore)
            .Configure(fun (application: IApplicationBuilder) ->
                application
                    .UseStaticFiles()
                    .UseRouting()
                    .UseEndpoints(fun endpoints ->
                        endpoints.MapBlazorHub() |> ignore
                        endpoints.MapFallbackToBolero(Index.page) |> ignore) |> ignore) |> ignore)
    .Build()
    .Run()
```
