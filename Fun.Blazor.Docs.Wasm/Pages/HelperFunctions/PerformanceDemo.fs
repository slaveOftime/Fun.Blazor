[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.PerformanceDemo

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components.Web.Virtualization
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components


let testLength = 10_000


let virtualizeDemo =
    adaptiview () {
        let! items, setItems = cval([||]).WithSetter()

        MudButton'() {
            Variant Variant.Filled
            OnClick(fun _ -> setItems [| 1..testLength |])
            childContent $"Create {testLength} items for virtualize test"
        }
        div {
            style {
                maxHeight 100
                overflowYAuto
            }
            Virtualize'() {
                Items items
                ChildContent(fun i ->
                    div {
                        style { color "blue" }
                        childContent $"item {i}"
                    }
                )
            }
        }
    }


let bigListDemo =
    MudPaper'() {
        style { padding 10 }
        childContent [
            adaptiview () {
                let! items, setItems = cval([||]).WithSetter()
                MudButton'() {
                    Variant Variant.Filled
                    OnClick(fun _ -> setItems [| 1..testLength |])
                    childContent $"Create {testLength} items for CE style"
                }
                div {
                    style {
                        marginTop 10
                        maxHeight 100
                        overflowYAuto
                    }
                    childContent [
                        for i in items do
                            div {
                                style { color "blue" }
                                childContent $"item {i}"
                            }
                    ]
                }
            }
            spaceV4
            adaptiview () {
                let! items, setItems = cval([||]).WithSetter()
                MudButton'() {
                    Variant Variant.Filled
                    OnClick(fun _ -> setItems [| 1..10_000 |])
                    childContent $"Create {testLength} items feliz style"
                }
                div {
                    style {
                        marginTop 10
                        maxHeight 100
                        overflowYAuto
                    }
                    childContent [
                        for i in items do
                            div {
                                style { color "green" }
                                $"item {i}"
                            }
                    ]
                }
            }
        ]
    }


let multipleChanges =
    adaptiview () {
        let v1 = cval 1
        let v2 = cval 2
        let v3 = cval 3

        let! n1 = v1
        let! n2 = v2
        let! n3 = v3

        MudButtonGroup'() {
            Variant Variant.Outlined
            childContent [
                MudButton'() {
                    OnClick(fun _ -> v1.Publish((+) 1))
                    childContent "Change n1"
                }
                MudButton'() {
                    OnClick(fun _ -> v2.Publish((+) 1))
                    childContent "Change n2"
                }
                MudButton'() {
                    OnClick(fun _ ->
                        // By this we can avoid multiple time calculation
                        transact
                        <| fun _ ->
                            v1.Value <- n1 + 1
                            v2.Value <- n2 + 1
                            v3.Value <- n3 + 1
                    )
                    childContent "Change all"
                }
                MudButton'() {
                    OnClick(fun _ ->
                        // By this we cannot avoid multiple time calculation
                        // Because Publish method already called transact
                        transact (fun _ ->
                            v1.Publish((+) 1)
                            v2.Publish((+) 1)
                            v3.Publish((+) 1)
                        )
                    )
                    childContent "Change all with nested transact"
                }
                MudButton'() {
                    OnClick(fun _ ->
                        v1.Publish((+) 1)
                        v2.Publish((+) 1)
                        v3.Publish((+) 1)
                    )
                    childContent "Change all without transact"
                }
            ]
        }
        div {
            style {
                marginTop 10
                fontWeightBold
                color "blue"
            }
            $"v1 = {n1}; v2 = {n2}; v3 = {n3}"
        }
    }


let performanceDemo =
    div.create [
        virtualizeDemo
        spaceV4
        bigListDemo
        spaceV4
        multipleChanges
    ]
