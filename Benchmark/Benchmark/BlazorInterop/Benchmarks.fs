namespace Benchmark.BlazorInterop

open BenchmarkDotNet.Attributes
open Microsoft.AspNetCore.Components.Rendering
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Operators


//[<MemoryDiagnoser>]
//type Benchmarks() =

//    [<Benchmark>]
//    member _.BuildRenderTreeWithGeneratedComp() =
//        use builder = new RenderTreeBuilder()
//        let render =
//            MudAlert'() {
//                Severity Severity.Success
//                Variant Variant.Filled
//                Elevation 10
//                Square true
//                Dense true
//                NoIcon true
//                html.text "Hi"
//            }
//        render.Invoke(null, builder, 0)


//    [<Benchmark>]
//    member _.BuildRenderTreeWithReflection() =
//        use builder = new RenderTreeBuilder()
//        let render =
//            html.blazor (fun ctx ->
//                MudAlert(
//                    Severity = Severity.Success,
//                    Variant = Variant.Filled,
//                    Elevation = 10,
//                    Square = true,
//                    Dense = true,
//                    NoIcon = true,
//                    ChildContent = ctx.Render(html.text "Hi")
//                )
//            )
//        render.Invoke(null, builder, 0)


//    [<Benchmark>]
//    member _.BuildRenderTreeWithOperators() =
//        use builder = new RenderTreeBuilder()
//        let render =

//            NodeRenderFragment(fun comp builder index ->
//                builder.OpenComponent<MudAlert>(index)

//                let renderAttrs =
//                    "Severity" => Severity.Success
//                    ==> ("Variant" => Variant.Filled)
//                    ==> ("Elevation" => 10)
//                    ==> ("Square" => true)
//                    ==> ("Dense" => true)
//                    ==> ("NoIcon" => true)
//                    ==> ("ChildContent" => comp.Render(html.text "Hi"))

//                let nextIndex = renderAttrs.Invoke(comp, builder, index + 1)
//                builder.CloseComponent()
//                nextIndex
//            )
//        render.Invoke(null, builder, 0)
