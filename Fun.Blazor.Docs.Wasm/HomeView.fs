// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Home

open Fun.Blazor
open Microsoft.JSInterop
open MudBlazor


let private simplestSyntax = div {
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
            Color Color.Primary
            "Simplest"
        }
        MudText'' {
            style {
                fontSize 24
                fontStyleItalic
                textAlignRight
            }
            Color Color.Secondary
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


let private flexsibleSyntax = div {
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
            Color Color.Primary
            "Flexsible"
        }
        MudText'' {
            style {
                fontSize 24
                fontStyleItalic
            }
            Color Color.Secondary
            "syntax"
        }
    }
}


let private multipleModeForDifferentUseCases = MudGrid'' {
    MudItem'' {
        xs 12
        sm 6
        md 4
        MudCard'' {
            MudCardMedia'' {
                Image ""
                Height 200
            }
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
                    simplestSyntax
                }
                MudCarouselItem'' {
                    Transition Transition.Slide
                    style {
                        displayFlex
                        alignItemsCenter
                        justifyContentCenter
                    }
                    flexsibleSyntax
                }
            }
            section {
                style { padding 72 12 }
                MudText'' {
                    Typo Typo.h2
                    Color Color.Secondary
                    style { textAlignCenter }
                    "You can run it in anywhere where dotnet can run!"
                }
                div {
                    style {
                        displayFlex
                        alignItemsCenter
                        justifyContentCenter
                        flexWrapWrap
                        gap 16
                    }
                    MudChip'' {
                        Color Color.Success
                        "asp.net core"
                    }
                    MudChip'' {
                        Color Color.Success
                        "browser"
                    }
                    MudChip'' {
                        Color Color.Info
                        "script: fsi"
                    }
                    MudChip'' {
                        Color Color.Secondary
                        "giraffe"
                    }
                    MudChip'' {
                        Color Color.Secondary
                        "falco"
                    }
                    MudChip'' {
                        Color Color.Default
                        Variant Variant.Text
                        "..."
                    }
                }
            }
        }
    )
