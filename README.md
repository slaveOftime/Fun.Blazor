# Fun.Blazor [![Nuget](https://img.shields.io/nuget/v/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine)

[WASM side docs](https://slaveoftime.github.io/Fun.Blazor/)

[Server side docs](https://funblazor.slaveoftime.fun)


## What you can get with this project?

1. Use F# ❤️😊 for blazor
2. Feliz and computation expression style DSL for internal and thrid party blazor libraries
4. Dependency injection (html.inject)
3. Elmish model (html.elmish), obervable model (html.watch), adaptive model(adaptiview)


## Some tips

1. Package Fun.Blazor: with basic stuff and CE style by default because it has better performance than Feliz style

```fsharp
    let demo =
        adaptiview(){
            let! v, setValue = FSharp.Data.Adaptive.cval(1).WithSetter()
            button(){
                onclick (fun _ -> setValue (v + 1))
                childContent "Increase"
            }
            div(){
                // In this way we can get intellicense in VSCode + Highlight HTML/SQL templates in F#
                css """_{
                    color: red;
                }"""
                // Or with plain string
                css "color: red;"
                childContent $"value = {v}"
            }
        }
```

2. Package Fun.Blazor.Feliz: will add feliz style DSL for basic dom/css

```fsharp
    open Fun.Blazor
    module evts = Bolero.Html.on

    let demo =
        adaptiview(){
            let! value, setValue = FSharp.Data.Adaptive.cval(1).WithSetter()
            html.button [
                attr.childContent "Increase"
                evts.click (fun _ -> setValue (value + 1))
            ]
            html.div [
                attr.styles [
                    style.color color.red
                ]
                attr.childContent $"value = {value}"
            ]
        }
```

3. Package Fun.Css: will enable CE style for css

```fsharp
    open Fun.Css
    open Fun.Blazor

    div(){
        css (CssBuilder(){
            color color.red
        })
        childContent "hello"
    }
```

4. Fun.Blazor.Cli: you can generate Feliz or CE style automatically for any blazor third party libraries

```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        MudCard'.create [
            MudAlert'(){
                Icon Icons.Filled.AccessAlarm
                childContent "This is the way"
            }
        ]
```

        Feliz style (should reference Fun.Blazor.Feliz)

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

## Create a WASM app (no debug support right now)

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

## Create a blazor server app

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
