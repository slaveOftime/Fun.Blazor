namespace Benchmark.BasicBenchmark

open BenchmarkDotNet.Attributes
open CSharpComponents


[<MemoryDiagnoser>]
type Benchmarks() =

    [<Benchmark>]
    member _.RenderWithRazorCSharp() = CSharpComponent().Build()

    [<Benchmark>]
    member _.RenderWithBolero() = BoleroComponent().Build()

    [<Benchmark>]
    member _.RenderWithFunBlazorCE() = CEComponent().Build()

    [<Benchmark>]
    member _.RenderWithFunBlazorTemplate() = TemplateComponent().Build()
