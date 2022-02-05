open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open CSharpComponents
open Fun.Blazor.Benchmark


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

    [<Benchmark>]
    member _.BuildRenderTreeWithFeliz() = FelizComponent().Build()


BenchmarkRunner.Run(typeof<Benchmarks>.Assembly) |> ignore
