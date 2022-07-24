open BenchmarkDotNet.Running

Benchmark.GenerateHtml.GiraffeDemo.run () |> printfn "%s"
Benchmark.GenerateHtml.FunBlazorDemo.run () |> printfn "%s"


BenchmarkRunner.Run(System.Reflection.Assembly.GetExecutingAssembly()) |> ignore
