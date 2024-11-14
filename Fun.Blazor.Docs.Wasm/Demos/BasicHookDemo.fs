// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.BasicHookDemo

open System.Threading.Tasks
open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor

let entry =
    /// It is same as html.inject
    html.inject (fun (hook: IComponentHook) ->
        let msg = cval "..."

        hook.AddFirstAfterRenderTask(fun () ->
            task {
                do! Task.Delay 3000
                msg.Publish "After first rendered"
            }
        )

        MudAlert'' {
            Severity Severity.Info
            adapt {
                let! msg = msg
                html.text msg
            }
        }
    )
