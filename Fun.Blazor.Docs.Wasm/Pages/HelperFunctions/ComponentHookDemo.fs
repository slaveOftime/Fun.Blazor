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
    
    mudPaper() {
        styles [ style.padding 20 ]
        childContent [
            html.watch (toggle, fun isToggled -> [
                mudText() {
                    childContent "We can use this hook to subscribe lifecycle event of the component which created by html.inject at the beginening. We can use create observable store to have a state management for the current component. After the component all the resource will be disposed."
                    typo Typo.subtitle1
                }
                mudText() {
                    childContent $"After every {threshhold} seconds the toggle will be switched"
                    typo Typo.subtitle1
                    color Color.Info
                }
                mudSwitch<bool>() {
                    checked' isToggled
                    checkedChanged (fun x -> toggle.Publish x)
                }
                if isToggled then
                    mudText() {
                        childContent "Toggled successfuly"
                        typo Typo.subtitle2
                        color Color.Primary
                    }
                else
                    mudText() {
                        childContent "Toggled off now"
                        color Color.Secondary
                    }
                html.watch (count, fun c -> html.text $"Interval Count: {c}")
            ])
        ]
    })
