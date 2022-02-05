open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open CSharpComponents
open Fun.Blazor.Benchmark


[<MemoryDiagnoser>]
type Benchmarks() =

    [<Benchmark>]
    member _.BuildRenderTreeForCE() = CEComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeForFeliz() = FelizComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeForTemplate() = TemplateComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeForBolero() = BoleroComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeForCSharp() = CSharpComponent().Build()


BenchmarkRunner.Run(typeof<Benchmarks>.Assembly) |> ignore
