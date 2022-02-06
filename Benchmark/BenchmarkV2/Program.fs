open BenchmarkDotNet.Running

BenchmarkRunner.Run(System.Reflection.Assembly.GetExecutingAssembly()) |> ignore
