open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open Fun.Blazor.Benchmark


[<MemoryDiagnoser>]
type Benchmarks() =

    [<Benchmark>]
    member _.BuildRenderTreeForCE() = CEComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeForFeliz() = FelizComponent().Build()

    [<Benchmark>]
    member _.BuildRenderTreeForTemplate() = TemplateComponent().Build()


BenchmarkRunner.Run(typeof<Benchmarks>.Assembly) |> ignore
