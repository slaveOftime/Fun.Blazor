namespace Benchmark.BasicBenchmark

open BenchmarkDotNet.Attributes
open CSharpComponents


[<MemoryDiagnoser>]
type Benchmarks() =

    do
        //Warming up
        CSharpComponent().Build()
        BoleroComponent().Build()
        FunBlazorComponentWithInlineCE().Build()
        FunBlazorComponentWithArray().Build()
        TemplateComponent().Build()
        SSRTemplateComponent().Build()

    [<Benchmark(Baseline = true)>]
    member _.RenderWithRazorCSharp() = CSharpComponent().Build()

    [<Benchmark>]
    member _.RenderWithBolero() = BoleroComponent().Build()
    
    [<Benchmark>]
    member _.RenderWithFunBlazorInlineCE() = FunBlazorComponentWithInlineCE().Build()

    [<Benchmark>]
    member _.RenderWithFunBlazorArray() = FunBlazorComponentWithArray().Build()

    [<Benchmark>]
    member _.RenderWithFunBlazorTemplate() = TemplateComponent().Build()

    [<Benchmark>]
    member _.RenderWithFunBlazorSSRTemplate() = SSRTemplateComponent().Build()
