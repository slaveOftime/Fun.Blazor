namespace Benchmark.StyleBuilding

open System.Text
open Microsoft.AspNetCore.Components.Rendering
open BenchmarkDotNet.Attributes
open Fun.Blazor
open Fun.Css
open Feliz


type FelizCssComponent() =
    inherit FunBlazorComponent()

    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)

    override _.Render() =
        let count = 1
        div {
            styles [
                style.color color.darkRed
                style.backgroundColor color.green
                style.height (length.percent 10)
                style.borderRadius 10
                style.displayFlex
                style.flexDirectionRow
                style.flexWrapWrap
                match count with
                | 0 ->
                    style.zIndex 10
                    style.alignContentFlexEnd
                | 1 ->
                    style.zIndex 16
                    style.alignContentFlexStart
                | _ -> style.alignContentInitial
            ]
        }
