namespace Fun.Blazor.Tests.Performances

open BenchmarkDotNet.Attributes
open Fun.Blazor
open Fun.Blazor.DslCE


type BoleroIntergration () as this =

    [<Params(10, 100, 1000, 10_000)>]
    member val Count = 1 with get, set

    [<Benchmark>]
    member _.Convert() =
        let comp =
            div(){
                styles [ style.maxHeight 100; style.overflowYAuto ]
                childContent [
                    for item in [1..this.Count] do
                        html.div $"item {item}"
                ]
            }

        comp.Node().ToBolero()
