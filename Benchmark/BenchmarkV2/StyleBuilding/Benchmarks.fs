namespace Benchmark.StyleBuilding

open BenchmarkDotNet.Attributes


[<MemoryDiagnoser>]
type Benchmarks() =

    [<Benchmark>]
    member _.BuildStyleWithCssBuilder() = CECssComponent().Build()


    [<Benchmark>]
    member _.BuildStyleWithFeliz() = FelizCssComponent().Build()
