// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.AsyncInjectionDemo

open System.Threading.Tasks
open Fun.Blazor

let entry =
    html.inject (fun () -> task {
        do! Task.Delay 2000
        return div { "well sleep" }
    })
