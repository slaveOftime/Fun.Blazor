// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.BlazorStyleComp

open Fun.Blazor
open MudBlazor

let entry =
    html.inject (fun (hook: IComponentHook) ->
        hook.SetDisableEventTriggerStateHasChanged false

        let amount = 1
        let mutable count = 0

        // Below is just a NodeRenderFragment which is a delegate
        // When you call hook.StateHasChanged() or by turn off DisableEventTriggerStateHasChanged and trigger event
        // Then it will trigger blazor rerender and the NodeRenderFragment delegate will be invoked.
        div {
            p { "Count="; count }
            MudButton'' {
                Size Size.Small
                Variant Variant.Outlined
                OnClick (fun _ -> count <- count + amount)
                "Increase count by "; amount
            }
        }
    )
