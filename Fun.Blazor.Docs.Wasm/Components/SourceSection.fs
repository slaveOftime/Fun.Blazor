[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.SourceSection

open System.Net.Http
open System.Threading.Tasks
open FSharp.Control.Reactive
open Microsoft.Extensions.Configuration
open Microsoft.AspNetCore.Hosting
open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Result


let sourceSection fileName = html.inject (fun (env: IHostingEnvironment, config: IConfiguration, store: ILocalStore, shareStore: IShareStore, hook: IComponentHook) ->
    let isDarkMode = ShareStores.isDarkMode shareStore
    let code = store.Create DeferredState<string, string>.Loading

    let observe (data: Task<Result<string, string>>) =
        data
        |> Async.AwaitTask
        |> Async.Catch
        |> Observable.ofAsync
        |> Observable.subscribe (function
            | Choice1Of2 (Ok x) -> code.Publish (DeferredState.Loaded x)
            | Choice1Of2 (Error x) -> code.Publish (DeferredState.LoadFailed x)
            | Choice2Of2 x -> code.Publish (DeferredState.LoadFailed x.Message))
        |> hook.AddDispose

    let getFromHostServer () =
        let path =
            #if DEBUG
            $"{env.ContentRootPath}/../Fun.Blazor.Docs.Wasm/wwwroot/code-docs/{fileName}.html"
            #else
            $"{env.ContentRootPath}/wwwroot/code-docs/{fileName}.html"
            #endif

        System.IO.File.ReadAllTextAsync(path)
        |> Task.map Ok
        |> observe

    let getFromGithub () =
        let client = new HttpClient()

        let host =
            #if DEBUG
            "https://localhost:5001"
            #else
            "https://slaveoftime.github.io/Fun.Blazor"
            #endif

        client.GetAsync($"{host}/code-docs/{fileName}.html")
        |> Task.bind (fun x -> 
            if x.IsSuccessStatusCode then x.Content.ReadAsStringAsync() |> Task.map Ok
            else x.StatusCode |> string |> Error |> Task.retn)
        |> observe

    if config <> null && config.GetValue<bool>("BlazorServerHost", false) then
        getFromHostServer()
    else
        getFromGithub()

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
