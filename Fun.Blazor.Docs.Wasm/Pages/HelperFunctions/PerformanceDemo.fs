[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.PerformanceDemo

open FSharp.Data.Adaptive
open Bolero.Html
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components
open MudBlazor.DslInternals
open Microsoft.AspNetCore.Components


let bigListDemo = html.inject <| fun () ->
    let lists1 = cval [1]
    let lists2 = cval [1]

    MudPaper'(){
        Styles [ style.padding 10 ]
        childContent [
            adaptiview(){
                let! lists' = lists1
                MudButton'(){
                    Variant Variant.Filled
                    OnClick (fun _ -> lists1.Publish [1..10_000])
                    childContent "Create list for CE style"
                }
                div(){
                    styles [ style.marginTop 10; style.maxHeight 100; style.overflowYAuto ]
                    childContent [
                        for i in lists' do
                            div(){
                                css """_{
                                    color: red;
                                }"""
                                childContent $"item {i}"
                            }
                    ]
                }
            }
            spaceV4
            adaptiview(){
                let! lists' = lists2
                MudButton'(){
                    Variant Variant.Filled
                    OnClick (fun _ -> lists2.Publish [1..10_000])
                    childContent "Create list for feliz style"
                }
                html.div [
                    attr.styles [ style.marginTop 10; style.maxHeight 100; style.overflowYAuto ]
                    attr.childContent [
                        for i in lists' do
                            html.div [
                                attr.styles [ style.color "green" ]
                                attr.childContent [
                                    html.text $"item {i}"
                                ]
                            ]
                    ]
                ]
            }
        ]
    }


let performanceDemo =
    html.div [
        bigListDemo
    ]
