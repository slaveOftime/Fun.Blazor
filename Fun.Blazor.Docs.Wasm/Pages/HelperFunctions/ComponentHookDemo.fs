[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.ComponentHookDemo

open System
open FSharp.Control.Reactive
open MudBlazor
open Fun.Result
open Fun.Blazor

let componentHookDemo = html.inject (fun (hook: IComponentHook) ->
    let toggle = hook.UseStore false
    let count = hook.UseStore 0
    let threshhold = 3

    hook.OnFirstAfterRender.Add (fun () ->
        TimeSpan.FromSeconds 1.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> count.Publish (fun x -> x + 1))
        |> hook.AddDispose
            
        count.Observable
        |> Observable.subscribe (function
            | GreaterThan threshhold -> toggle.Publish not; count.Publish 0
            | _ -> ())
        |> hook.AddDispose)
    
    MudPaper'() {
        Styles [ style.padding 20 ]
        childContent [
            html.watch (toggle, fun isToggled -> [
                MudText'() {
                    childContent "We can use this hook to subscribe lifecycle event of the component which created by html.inject at the beginening. We can create observable store to have a state management for the current component. After the component disposed all the store will also be disposed."
                    Typo Typo.subtitle1
                }
                MudText'() {
                    childContent $"After every {threshhold} seconds the toggle will be switched"
                    Typo Typo.subtitle1
                    Color Color.Info
                }
                MudSwitch'<bool>() {
                    Checked isToggled
                    CheckedChanged (fun (x: bool) -> toggle.Publish x)
                }
                if isToggled then
                    MudText'() {
                        childContent "Toggled successfuly"
                        Typo Typo.subtitle2
                        Color Color.Primary
                    }
                else
                    MudText'() {
                        childContent "Toggled off now"
                        Color Color.Secondary
                    }
                html.watch (count, fun c -> html.text $"Interval Count: {c}")
            ])
        ]
    })
