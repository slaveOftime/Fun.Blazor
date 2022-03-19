[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.SourceSection

open System.Net.Http
open System.Threading.Tasks
open FSharp.Control.Reactive
open Microsoft.Extensions.Configuration
open Microsoft.AspNetCore.Hosting
open Microsoft.JSInterop
open MudBlazor
open Fun.Result
open Fun.Blazor


let private deferredObserve (data: Task<Result<string, string>>) =
    data
    |> Async.AwaitTask
    |> Async.Catch
    |> Observable.ofAsync
    |> Observable.map (
        function
        | Choice1Of2 (Ok x) -> DeferredState.Loaded x
        | Choice1Of2 (Error x) -> DeferredState.LoadFailed x
        | Choice2Of2 x -> DeferredState.LoadFailed x.Message
    )


let private version = "2.0.0-beta031"


let private getFromHostServer (env: IHostingEnvironment) (fileName: string) =
    let path =
#if DEBUG
        $"{env.ContentRootPath}/../Fun.Blazor.Docs.Wasm/wwwroot/code-docs/{fileName}.html"
#else
        $"{env.ContentRootPath}/wwwroot/code-docs/{fileName}.html"
#endif

    System.IO.File.ReadAllTextAsync(path) |> Task.map Ok |> deferredObserve


let private getFromGithub (fileName: string) =
    let client = new HttpClient()

    let host =
#if DEBUG
        "https://localhost:5001"
#else
        "https://slaveoftime.github.io/Fun.Blazor.Docs"
#endif

    client.GetAsync($"{host}/code-docs/{fileName}.html?v={version}")
    |> Task.bind (fun x ->
        if x.IsSuccessStatusCode then
            x.Content.ReadAsStringAsync() |> Task.map Ok
        else
            x.StatusCode |> string |> Error |> Task.retn
    )
    |> deferredObserve


let sourceSection fileName =
    html.inject (
        fileName,
        fun (env: IHostingEnvironment, config: IConfiguration, globalStore: IGlobalStore, hook: IComponentHook, js: IJSRuntime) ->
            let code =
                globalStore.CreateDeferred(
                    $"code-source-{fileName}",
                    fun () ->
                        if config <> null && config.GetValue<bool>("BlazorServerHost", false) then
                            getFromHostServer env fileName
                        else
                            getFromGithub fileName
                )

            hook.OnFirstAfterRender.Add(fun () ->
                js.highlightCode () |> ignore
                hook.AddDisposes [
                    code.Observable.Subscribe(
                        function
                        | DeferredState.Loaded _ -> js.highlightCode () |> ignore
                        | _ -> ()
                    )
                ]
            )

            html.watch (
                code,
                function
                | DeferredState.Loading ->
                    MudProgressLinear'() {
                        Color Color.Primary
                        Indeterminate true
                    }
                | DeferredState.Loaded codes ->
                    div {
                        article {
                            class' "markdown-body"
                            html.raw codes
                        }
                    }
                | DeferredState.LoadFailed e ->
                    MudAlert'() {
                        Severity Severity.Error
                        childContent e
                    }
                | _ -> html.none
            )
    )
