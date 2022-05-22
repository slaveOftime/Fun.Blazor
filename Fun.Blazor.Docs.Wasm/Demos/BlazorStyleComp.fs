// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.BlazorStyleComp

open Fun.Blazor

let entry =
    html.comp (fun (hook: IComponentHook) ->
        hook.SetDisableEventTriggerStateHasChanged false

        let mutable count = 0

        // Below is just a NodeRenderFragment which is a delegate
        // When you call hook.StateHasChanged() or by turn off DisableEventTriggerStateHasChanged and trigger event 
        // Then it will trigger blazor rerender and the NodeRenderFragment delegate will be invoked.
        div {
            div { $"Here is the count {count}" }
            button {
                onclick (fun _ -> count <- count + 1)
                "Increase"
            }
        }
    )
