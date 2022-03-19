[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.HtmlWatchDemo

open System
open FSharp.Control.Reactive
open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Wasm.Components


// I provide html.watch and IComponentHook is to enrich elmish not replace it
// Currently it does not provide batch update and also not easy to consume
// But it can provide some benifit for elmish like manage some little local state


let htmlWatchDemo = html.inject (fun (hook: IComponentHook) ->
    let store1 = hook.UseStore 0
    let store2 = hook.UseStore 0

    hook.OnFirstAfterRender.Add(fun () ->
        TimeSpan.FromSeconds 3.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store1.Publish ((+) 1))
        |> hook.AddDispose

        TimeSpan.FromSeconds 1.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store2.Publish ((+) 1))
        |> hook.AddDispose
    )

    MudPaper'(){
        style { padding 20 }
        childContent [
            // We can use this to watch IStore<_>
            // When anything changed in the store we will call the render function you provided below
            html.watch (store1, fun s1 -> [
                MudText'.create $"store1: {s1}"
                MudText'.create $"store2: {store2.Current}" // This will only be updated when store1 is changed
                html.watch (store2, fun s2 -> [
                    MudText'.create $"store1 in second watch: {s1}"
                    MudText'.create $"store2 in second watch: {s2}"
                ])
            ])
            spaceV3
            // You can watch two store or even three store at one time
            html.watch2 (store1, store2, fun s1 s2 -> [
                MudText'.create $"store1: {s1}"
                MudText'.create $"store2: {s2}"
            ])
        ]
    })
