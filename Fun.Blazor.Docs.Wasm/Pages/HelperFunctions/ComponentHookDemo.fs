[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.ComponentHookDemo

open System
open FSharp.Control.Reactive
open MudBlazor
open Fun.Result
open Fun.Blazor

let componentHookDemo =
    html.inject (fun (hook: IComponentHook) ->
        let toggle = hook.UseStore false
        let count = hook.UseStore 0
        let taskMsg1 = hook.UseStore ""
        let taskMsg2 = hook.UseStore ""
        let threshhold = 3

        hook.OnInitialized.Add(fun () ->
            toggle.Publish true
            count.Publish((+) 10)
        )

        hook.AddInitializedTask(fun () ->
            task {
                taskMsg1.Publish "Initialized task delay starting"
                do! System.Threading.Tasks.Task.Delay 3000
                taskMsg1.Publish "Initialized task delay finished"
            }
        )

        hook.OnFirstAfterRender.Add(fun () ->
            TimeSpan.FromSeconds 1.
            |> Observable.interval
            |> Observable.subscribe (fun _ -> count.Publish(fun x -> x + 1))
            |> hook.AddDispose

            count.Observable
            |> Observable.subscribe (
                function
                | GreaterThan threshhold ->
                    toggle.Publish not
                    count.Publish 0
                | _ -> ()
            )
            |> hook.AddDispose
        )

        hook.AddAfterRenderTask(fun firstRender ->
            task {
                taskMsg2.Publish "AfterRender task delay starting"
                do! System.Threading.Tasks.Task.Delay 3000
                taskMsg2.Publish "AfterRender task delay finished"
            }
        )


        MudPaper'() {
            style { padding 20 }
            html.watch (
                toggle,
                fun isToggled ->
                    [
                        MudText'() {
                            Typo Typo.subtitle1
                            childContent
                                "We can use this hook to subscribe lifecycle event of the component which created by html.inject at the beginening. We can create observable store to have a state management for the current component. After the component disposed all the store will also be disposed."
                        }
                        MudText'() {
                            Typo Typo.subtitle1
                            Color Color.Info
                            childContent $"After every {threshhold} seconds the toggle will be switched"
                        }
                        MudSwitch'<bool>() {
                            Checked isToggled
                            CheckedChanged(fun (x: bool) -> toggle.Publish x)
                        }
                        if isToggled then
                            MudText'() {
                                Typo Typo.subtitle2
                                Color Color.Primary
                                childContent "Toggled successfuly"
                            }
                        else
                            MudText'() {
                                Color Color.Secondary
                                childContent "Toggled off now"
                            }
                        html.watch (count, (fun c -> div { $"Interval Count: {c}" }))
                        html.watch (taskMsg1, (fun c -> div { $"Task msg 1 : {c}" }))
                        html.watch (taskMsg2, (fun c -> div { $"Task msg 2 : {c}" }))
                    ]
            )
        }
    )
