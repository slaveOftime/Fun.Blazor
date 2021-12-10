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


## Please check the samples for quick start

https://github.com/slaveOftime/Fun.Blazor.Samples

## Some tips

1. Fun.Blazor: with basic stuff and CE style by default because it has better performance than Feliz style

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

2. Fun.Blazor.Feliz: will add feliz style DSL for basic dom/css

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

3. Fun.Css: will enable CE style for css

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

    [Docs for how to use it](https://funblazor.slaveoftime.fun/cli-usage)
    
    Fun.Blazor.Feliz package is required

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

5. Fun.Blazor.HtmlTemplate: is help you to convert plain string to dom tree. And with VSCode + Ionide-fsharp + Highlight HTML/SQL templates you can get embeded intellicense.

```fsharp
    let congratulations =
        Template.html $"""
            <div style="color: hotpink;">Congratulations! You made it ❤️</div>
        """
```