[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.ComponentHookDemo

open System
open FSharp.Control.Reactive
open MudBlazor
open Fun.Result
open Fun.Blazor
open Fun.Blazor.MudBlazor

let componentHookDemo = html.inject (fun (hook: IComponentHook) ->
    let toggle = hook.UseStore false
    let count = hook.UseStore 0
    let threshhold = 3

    hook.OnAfterRender.Subscribe (function
        | false -> ()
        | true ->
            TimeSpan.FromSeconds 1.
            |> Observable.interval
            |> Observable.subscribe (fun _ -> count.Publish (fun x -> x + 1))
            |> hook.AddDispose
            
            count.Observable
            |> Observable.subscribe (function
                | GreaterThan threshhold -> toggle.Publish not; count.Publish 0
                | _ -> ())
            |> hook.AddDispose)
        |> hook.AddDispose
    
    mudPaper.create [
        attr.styles [ style.padding 20 ]
        html.watch (toggle, fun isToggled -> [
            mudText.create [
                mudText.childContent "We can use this hook to subscribe lifecycle event of the component which created by html.inject at the beginening. We can use create observable store to have a state management for the current component. After the component all the resource will be disposed."
                mudText.typo Typo.subtitle1
            ]
            mudText.create [
                mudText.childContent $"After every {threshhold} seconds the toggle will be switched"
                mudText.typo Typo.subtitle1
                mudText.color Color.Info
            ]
            mudSwitch<bool>.create [
                mudSwitch.checked' isToggled
                mudSwitch.checkedChanged toggle.Publish
            ]
            if isToggled then
                mudText.create [
                    mudText.childContent "Toggled successfuly"
                    mudText.typo Typo.subtitle2
                    mudText.color Color.Primary
                ]
            else
                mudText.create [
                    mudText.childContent "Toggled off now"
                    mudText.color Color.Secondary
                ]
            html.watch (count, fun c -> html.text $"Interval Count: {c}")
        ])
    ])
