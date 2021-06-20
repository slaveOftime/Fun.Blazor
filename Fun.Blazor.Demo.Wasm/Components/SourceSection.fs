[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Components.SourceSection

open System.Net.Http
open FSharp.Control.Reactive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Result


let sourceSection fileName = html.inject (fun (store: ILocalStore, shareStore: IShareStore, hook: IComponentHook) ->
    let isDarkMode = shareStore.Create ("isDarkMode", false)
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

    html.watch (code, function
        | DeferredState.Loading ->
            mudProgressLinear.create [
                mudProgressLinear.color Color.Primary
                mudProgressLinear.indeterminate true
            ]
        | DeferredState.Loaded code ->
            html.div [
                html.article [
                    attr.classes [ "markdown-body" ]
                    html.raw code
                ]
                html.watch (isDarkMode, fun isDark -> [
                    html.stylesheet "css/github-markdown.css"
                    if isDark then 
                        html.stylesheet "css/prism-vsc-dark-plus.css"
                    else
                        html.stylesheet "css/prism-vs.css"
                    //html.stylesheet "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/themes/prism.min.css"
                    html.script "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/components/prism-core.min.js"
                    html.script "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/plugins/autoloader/prism-autoloader.min.js"
                ])
            ]
        | DeferredState.LoadFailed e ->
            mudAlert.create [
                mudAlert.childContent e
                mudAlert.severity Severity.Error
            ]
        | _ -> html.none
    ))
