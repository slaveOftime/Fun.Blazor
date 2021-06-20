[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Components.SourceSection

open System.Net.Http
open FSharp.Control.Reactive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Result


let sourceSection fileName = html.inject (fun (store: ILocalStore, hook: IComponentHook) ->
    let code = store.Create DeferredState<string, string>.Loading

    let client = new HttpClient()
    let host =
        #if DEBUG
        "https://localhost:5001"
        #else
        "https://slaveoftime.github.io/Fun.Blazor"
        #endif

    client.GetAsync($"{host}/code-docs/{fileName}.html")
    |> Task.bind (fun x -> 
        if x.IsSuccessStatusCode then x.Content.ReadAsStringAsync() |> Task.map DeferredState.Loaded
        else x.StatusCode |> string |> DeferredState.LoadFailed |> Task.retn)
    |> Async.AwaitTask
    |> Async.Catch
    |> Observable.ofAsync
    |> Observable.subscribe (function
        | Choice1Of2 x -> code.Publish x
        | Choice2Of2 x -> code.Publish (DeferredState.LoadFailed x.Message))
    |> hook.AddDispose
    
    hook.AddDispose client


    html.watch (code, function
        | DeferredState.Loading -> mudProgressLinear.create []
        | DeferredState.Loaded code ->
            html.article [
                attr.classes [ "markdown-body" ]
                html.raw code
            ]
        | DeferredState.LoadFailed e ->
            mudAlert.create [
                mudAlert.children e
                mudAlert.severity Severity.Error
            ]
        | _ -> html.none
    ))
