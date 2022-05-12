namespace Benchmark.BasicBenchmark

open BenchmarkDotNet.Attributes
open CSharpComponents


[<MemoryDiagnoser>]
type Benchmarks() =

    [<Benchmark>]
    member _.BuildRenderTreeWithCSharp() = CSharpComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeWithBolero() = BoleroComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeWithCE() = CEComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeWithTemplate() = TemplateComponent().Build()
