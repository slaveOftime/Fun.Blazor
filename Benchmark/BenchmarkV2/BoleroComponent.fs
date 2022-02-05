namespace Fun.Blazor.Benchmark

open Microsoft.AspNetCore.Components.Rendering
open Bolero
open Bolero.Html


type BoleroComponent() =
    inherit Component()


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)


    override _.Render() =
        let count = 1
        div [ attr.``class`` "1"; attr.style "color: red;" ] [
            p [ attr.``class`` "class" ] [
                text "p"
            ]
            p [ attr.``class`` "class" ] [
                text "p"
            ]
            p [ attr.``class`` "class" ] [
                text "p"
            ]
            p [ attr.``class`` "class" ] [
                text "p"
            ]
            p [ attr.``class`` "class" ] [
                text "p"
            ]
            section [] [
                p [ attr.``class`` "class" ] [
                    text "p"
                ]
                p [ attr.``class`` "class" ] [
                    text $"Count = {count}"
                ]
                button [ Html.on.click (fun _ -> ()) ] [
                    text "Increase"
                ]
            ]
        ]
