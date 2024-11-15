// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.AdaptiviewMathDemo

open System
open FSharp.Data.Adaptive
open FSharp.Control.Reactive
open Fun.Result
open Fun.Blazor

let entry =
    html.inject (fun (hook: IComponentHook) ->
        let xaxis = cval 0

        hook.AddDisposes [
            Observable.interval (TimeSpan.FromMilliseconds 200)
            |> Observable.subscribe (fun x -> xaxis.Publish(int (Math.Sin(float x) * 400. + 400.)))
        ]

        div {
            style {
                padding 10 100 10 100
                positionRelative
                height 300
            }
            adapt {
                let! y =
                    xaxis
                    |> AVal.map (
                        function
                        | LessEqual 100 -> 100
                        | Between 100 200 -> 150
                        | _ -> 200
                    )
                div {
                    style {
                        positionAbsolute
                        top y
                        left 0
                        right 0
                        height 2
                        backgroundColor "hotpink"
                    }
                    DateTime.Now.ToString()
                }
            }
            adapt {
                let! x = xaxis
                let y = 150. + Math.Sin(float x) * 100. |> int
                div {
                    style {
                        positionAbsolute
                        top y
                        left x
                        height 40
                        width 100
                        backgroundColor "blue"
                        color "white"
                    }
                    DateTime.Now.ToString()
                }
            }
        }
    )
