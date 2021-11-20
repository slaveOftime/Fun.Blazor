[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.PerformanceDemo

open FSharp.Data.Adaptive
open Fun.Css
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components

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


let multipleChanges = html.inject <| fun () ->
    let v1 = cval 1
    let v2 = cval 2
    let v3 = cval 3

    adaptiview(){
        let! n1 = v1
        let! n2 = v2
        let! n3 = v3

        MudButtonGroup'(){
            Variant Variant.Outlined
            childContent [
                MudButton'(){
                    OnClick (fun _ -> v1.Publish ((+) 1))
                    childContent "Change n1"
                }
                MudButton'(){
                    OnClick (fun _ -> v2.Publish ((+) 1))
                    childContent "Change n2"
                }
                MudButton'(){
                    OnClick (fun _ ->
                        // By this we can avoid multiple time calculation
                        transact <| fun _ ->
                            v1.Value <- n1 + 1
                            v2.Value <- n2 + 1
                            v3.Value <- n3 + 1)
                    childContent "Change all"
                }
                MudButton'(){
                    OnClick (fun _ ->
                        v1.Publish ((+) 1)
                        v2.Publish ((+) 1)
                        v3.Publish ((+) 1))
                    childContent "Change all without transact"
                }
            ]
        }
        div(){
            css (CssBuilder(){
                marginTop 10
                fontWeightBold
                color "blue"
            })
            childContent $"v1 = {n1}; v2 = {n2}; v3 = {n3}"
        }
    }


let performanceDemo =
    html.div [
        bigListDemo
        spaceV4
        multipleChanges
    ]
