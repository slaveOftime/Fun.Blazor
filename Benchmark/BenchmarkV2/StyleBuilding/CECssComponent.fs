namespace Benchmark.StyleBuilding

open System.Text
open Microsoft.AspNetCore.Components.Rendering
open BenchmarkDotNet.Attributes
open Fun.Blazor
open Fun.Css
open Feliz


type CECssComponent() =
    inherit FunBlazorComponent()

    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)

    override _.Render() =
        let count = 1
        div {
            style'' {
                color color.darkRed
                backgroundColor color.green
                height "10%"
                borderRadius 10
                displayFlex
                flexDirectionRow
                flexWrapWrap
                match count with
                | 0 ->
                    css'' {
                        zIndex 10
                        alignContentFlexEnd
                    }
                | 1 ->
                    css'' {
                        zIndex 16
                        alignContentFlexStart
                    }
                | _ -> css'' { alignContentInitial }
            }
        }
