namespace Benchmark.BasicBenchmark

open BenchmarkDotNet.Attributes
open CSharpComponents


[<MemoryDiagnoser>]
type Benchmarks() =

    do
        //Warming up
        CSharpComponent().Build()
        BoleroComponent().Build()
        CEComponent().Build()
        TemplateComponent().Build()
        SSRTemplateComponent().Build()

    [<Benchmark>]
    member _.RenderWithRazorCSharp() = CSharpComponent().Build()

    [<Benchmark>]
    member _.RenderWithBolero() = BoleroComponent().Build()

    [<Benchmark>]
    member _.RenderWithFunBlazorCE() = CEComponent().Build()

    // [<Benchmark>]
    // member _.RenderWithFunBlazorTemplate() = TemplateComponent().Build()

    // [<Benchmark>]
    // member _.RenderWithFunBlazorSSRTemplate() = SSRTemplateComponent().Build()
