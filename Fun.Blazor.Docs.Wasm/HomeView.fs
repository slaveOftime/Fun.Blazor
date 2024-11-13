// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Home

open Fun.Blazor
open Microsoft.JSInterop
open MudBlazor


let private simplestSyntaxDemo = div {
    style {
        displayFlex
        alignItemsCenter
        flexWrapWrap
        justifyContentCenter
        gap 64
        margin "12px" "auto"
    }
    section {
        MudText'' {
            style {
                fontStyleItalic
                opacity 0.8
                textAlignRight
            }
            "The"
        }
        MudText'' {
            style {
                fontSize 48
                fontWeightBolder
                textDecorationUnderline
            }
            class' "animated-glow-secondary-text"
            Color Color.Primary
            "Simplest"
        }
        MudText'' {
            style {
                fontSize 24
                fontStyleItalic
                textAlignRight
            }
            "syntax"
        }
    }
    MudPaper'' {
        Elevation 5
        pre {
            code {
                class' "language-fsharp"
                """div {
    style {
        color "pink"
        backgroundColor "yellow"
    }
    "Hello "
    DateTime.Now.ToString()
    span { "🎉" }
    br
    p { }
    p { "The simplest syntax you can get" }
}"""
            }
        }
    }
}


let private flexibleSyntaxDemo = div {
    style {
        displayFlex
        alignItemsCenter
        flexWrapWrap
        justifyContentCenter
        gap 64
        margin "12px" "auto"
    }
    MudPaper'' {
        Elevation 5
        pre {
            if true then ""
            code {
                class' "language-fsharp"
                """type CssBuilder with

    [<CustomOperation("vocationStyle")>]
    member inline _.vocationStyle([<InlineIfLambda>] comb: CombineKeyValue) =
        comb
        &&& css {
            custom "border-bottom" "8px solid blue"
            backgroundBlendModeColor
        }

let hello = p { "hello" } 

let vacation = 
    html.inject (fun (calendarService: ICalendarService) -> div {
        style { 
            padding 12
            vocationStyle
        }
        "Get and display my vocations here"
    })

div {
    hello
    if System.DateTime.Now.DayOfWeek > 5 then 
        vacation
        section { "🎉" }
}"""
            }
        }
    }
    section {
        MudText'' {
            style {
                fontStyleItalic
                opacity 0.8
            }
            "The most"
        }
        MudText'' {
            style {
                fontSize 48
                fontWeightBolder
                textDecorationUnderline
            }
            class' "animated-glow-secondary-text"
            Color Color.Primary
            "Flexsible"
        }
        MudText'' {
            style {
                fontSize 24
                fontStyleItalic
            }
            "syntax"
        }
    }
}


let private multipleModeForDifferentUseCases = MudGrid'' {
    Justify Justify.Center
    Spacing 10
    style { maxWidth 1080 }
    MudItem'' {
        xs 12
        sm 6
        md 4
        MudCard'' {
            Outlined
            MudCardMedia'' {
                Image "ssr.jpg"
                Height 200
            }
            MudCardContent'' {
                MudText'' {
                    class' "animated-glow-secondary-text"
                    Typo Typo.h5
                    "SSR (Server side rendering)"
                }
                MudText'' {
                    Typo Typo.body2
                    "Everything can be rendered on the server and streamed to browser and improve SEO etc."
                }
                MudText'' {
                    Typo Typo.body2
                    "This is mainly for static page rendering or first load for some pages."
                }
            }
        }
    }
    MudItem'' {
        xs 12
        sm 6
        md 4
        MudCard'' {
            Outlined
            MudCardMedia'' {
                Image "signalr.svg"
                Height 200
            }
            MudCardContent'' {
                MudText'' {
                    class' "animated-glow-secondary-text"
                    Typo Typo.h5
                    "Server Mode"
                }
                MudText'' {
                    Typo Typo.body2
                    "Can do very complex interactive UI logic."
                }
                MudText'' {
                    Typo Typo.body2
                    "Very productive for enterprise internal tools, because there is no need to build any RESTful APIs, everything is handled on server."
                }
                MudText'' {
                    Typo Typo.body2
                    "Will need WebSocket support, so the network or connectivity will have large impact on its use cases."
                }
            }
        }
    }
    MudItem'' {
        xs 12
        sm 6
        md 4
        MudCard'' {
            Outlined
            MudCardMedia'' {
                Image "wasm.png"
                Height 200
            }
            MudCardContent'' {
                MudText'' {
                    class' "animated-glow-secondary-text"
                    Typo Typo.h5
                    "Client Mode (WASM)"
                }
                MudText'' {
                    Typo Typo.body2
                    "Like all other frameworks' WASM mode, will load all the code in the browser and run locally. So the download size may be a little big."
                }
            }
        }
    }
    MudItem'' {
        xs 12
        sm 6
        md 4
        MudCard'' {
            Outlined
            MudCardMedia'' {
                Image "hyper1.jpg"
                Height 200
            }
            MudCardContent'' {
                MudText'' {
                    class' "animated-glow-secondary-text"
                    Typo Typo.h5
                    "Hyper Mode"
                }
                MudText'' {
                    Typo Typo.body2
                    "Get all the benifits, but yes it will introduce more complexity."
                }
                MudText'' {
                    Typo Typo.body2
                    "For example, the first load can be SSR, a quick and fast static page will be sent to user. Then will check if the client side file (WASM) is downloaded before, if not then will use server mode to serve the logic, and in the background the WASM files will be loaded for the next time's usage."
                }
            }
        }
    }
    MudItem'' {
        xs 12
        sm 6
        md 4
        MudCard'' {
            Outlined
            MudCardMedia'' {
                Image "hyper2.jpg"
                Height 200
            }
            MudCardContent'' {
                MudText'' {
                    class' "animated-glow-secondary-text"
                    Typo Typo.h5
                    "Hyper mode 2"
                }
                MudText'' {
                    Typo Typo.body2
                    "Prefer SSR first, then for simple interactive logic use "
                    MudText'' {
                        Typo Typo.body2
                        Color Color.Success
                        Inline
                        "HTMX"
                    }
                    " to do partial html patch. "
                    "For rich interactive, we can use server mode and only render it when it's in view."
                }
            }
        }
    }
}


let private ecosystemIcons = [
    "mudblazor.svg", "https://mudblazor.com/"
    "antdesign.svg", "https://antblazor.com/"
    "apexcharts.svg", "https://apexcharts.github.io/Blazor-ApexCharts/"
    "fluentui.svg", "https://github.com/microsoft/fluentui-blazor"
    "diagram.png", "https://blazor-diagrams.zhaytam.com/"
    "telerik.svg", "https://www.telerik.com/blazor-ui"
    "radzen.svg", "https://blazor.radzen.com/?theme=material3"
]

let private richEcosystem = div {
    style {
        displayFlex
        alignItemsCenter
        justifyContentCenter
        maxWidth 720
        flexWrapWrap
        gap 48
    }
    for icon, url in ecosystemIcons do
        a {
            href url
            MudImage'' {
                Src $"ecosystem/{icon}"
                Height 80
            }
        }
}


let home =
    html.inject (fun (hook: IComponentHook, js: IJSRuntime) ->
        hook.AddFirstAfterRenderTask(fun _ -> task {
            do! Async.Sleep 3000
            do! js.highlightCode ()
        })

        div {
            style { marginTop -64 }
            MudCarousel'' {
                style {
                    height 700
                    overflowYAuto
                    backgroundImageUrl "hero.webp"
                }
                ShowArrows
                ShowBullets
                EnableSwipeGesture
                AutoCycle
                SelectedIndexChanged(fun _ -> task { do! js.highlightCode () })
                MudCarouselItem'' {
                    Transition Transition.Slide
                    style {
                        displayFlex
                        alignItemsCenter
                        justifyContentCenter
                    }
                    simplestSyntaxDemo
                }
                MudCarouselItem'' {
                    Transition Transition.Slide
                    style {
                        displayFlex
                        alignItemsCenter
                        justifyContentCenter
                    }
                    flexibleSyntaxDemo
                }
            }
            section {
                style {
                    padding 72 12
                    displayFlex
                    flexDirectionColumn
                    alignItemsCenter
                    gap 24
                }
                MudText'' {
                    Typo Typo.h2
                    "You can run it in anywhere where dotnet can run!"
                }
                div {
                    style {
                        displayFlex
                        alignItemsCenter
                        justifyContentCenter
                        flexWrapWrap
                        gap 12
                    }
                    MudChip'' { "asp.net core" }
                    MudChip'' { "browser" }
                    MudChip'' { "script: fsi" }
                    MudChip'' { "giraffe" }
                    MudChip'' { "falco" }
                    MudChip'' {
                        Variant Variant.Text
                        "..."
                    }
                }
                MudButton'' {
                    Color Color.Success
                    Variant Variant.Filled
                    Href "/Docs/Get-Started"
                    "Get Started"
                }
            }
            section {
                style {
                    padding 48 12
                    backgroundColor "var(--mud-palette-surface)"
                    displayFlex
                    flexDirectionColumn
                    alignItemsCenter
                }
                multipleModeForDifferentUseCases
            }
            section {
                style {
                    padding 48 12
                    displayFlex
                    flexDirectionColumn
                    alignItemsCenter
                    gap 24
                    backgroundColor "var(--mud-palette-primary)"
                }
                richEcosystem
                MudText'' {
                    Typo Typo.h5
                    "Access to rich ecosystem by auto-generated/pre-generated bindings!!! ❤️"
                }
            }
            section {
                style {
                    displayFlex
                    flexDirectionColumn
                    alignItemsCenter
                    gap 12
                    padding 64 12 12 0
                }
                MudText'' {
                    Typo Typo.body2
                    Align Align.Center
                    "You can contact the main maintainer if you need commercial support"
                }

                MudText'' {
                    name "email"
                    Typo Typo.body2
                    Align Align.Center
                    "albertwoo_slaveoftime@hotmail.com"
                }
                MudText'' {
                    Typo Typo.body2
                    Align Align.Center
                    Color Color.Warning
                    "You can also donate/support by"
                }
                Static.html
                    """
                    <a href="https://paypal.me/wubinwen" style="display: flex; align-items: center; gap: 12px;">
                        <img src="https://www.paypalobjects.com/paypal-ui/logos/svg/paypal-color.svg" height="30">
                    </a>
                    """
            }
        }
    )
