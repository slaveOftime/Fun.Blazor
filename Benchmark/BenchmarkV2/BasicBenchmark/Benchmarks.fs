namespace Benchmark.BasicBenchmark

open BenchmarkDotNet.Attributes
open CSharpComponents


[<MemoryDiagnoser>]
type Benchmarks() =

    [<Benchmark>]
    member _.Build_RazorCSharp() = CSharpComponent().Build()

    [<Benchmark>]
    member _.Build_Bolero() = BoleroComponent().Build()

    [<Benchmark>]
    member _.Build_FunCssCE() = CEComponent().Build()

    [<Benchmark>]
    member _.Build_FunCssTemplate() = TemplateComponent().Build()
