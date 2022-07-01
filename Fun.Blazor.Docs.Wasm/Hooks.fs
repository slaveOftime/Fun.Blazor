[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Hooks

open System.Net
open System.Net.Http
open System.Text.Json
open System.Text.Json.Serialization
open FSharp.Data.Adaptive
open Microsoft.JSInterop
open Fun.Result
open Fun.Blazor
open MudBlazor


let private jsonOptions =
    let options = JsonSerializerOptions()
    options.Converters.Add(JsonFSharpConverter())
    options


type IShareStore with

    member store.IsServerSideRendering =
        let js = store.ServiceProvider.GetMultipleServices<IJSRuntime>()
        let isWasm =
            match js with
            | :? IJSInProcessRuntime -> true
            | _ -> false
        store.CreateCVal(nameof store.IsServerSideRendering, not isWasm)

    member store.IsDarkMode = store.CreateCVal(nameof store.IsDarkMode, true)


type IComponentHook with

    member hook.ShareStore = hook.ServiceProvider.GetMultipleServices<IShareStore>()


    /// This is used for handle server side rendering call or async call if it is not first time rendering on server
    member hook.RenderCall map data =
        if hook.ShareStore.IsServerSideRendering.Value then
            data |> Task.runSynchronously |> map
        else
            data |> Task.map map |> ignore


    member hook.GetHttpString(url: string) =
        let snackbar, http =
            hook.ServiceProvider.GetMultipleServices<ISnackbar * HttpClient>()
        task {
            try
                let! result = http.GetAsync(url).ConfigureAwait(false)
                if result.IsSuccessStatusCode then
                    let! str = result.Content.ReadAsStringAsync().ConfigureAwait(false)
                    return Some str
                else if result.StatusCode = HttpStatusCode.NotFound then
                    return None
                else
                    return None
            with
            | ex ->
                snackbar.Add(ex.Message, Severity.Error) |> ignore
                return None
        }

    member hook.ParseJson<'T>(jsonStr: string) =
        let snackbar = hook.ServiceProvider.GetMultipleServices<ISnackbar>()
        try
            JsonSerializer.Deserialize<'T>(jsonStr, jsonOptions) |> Some
        with
        | ex ->
            snackbar.Add(ex.Message, Severity.Error) |> ignore
            None


    /// Get docs tree json file and save it to global store
    member hook.GetOrLoadDocsTree() =
        let globalStore = hook.ServiceProvider.GetMultipleServices<IGlobalStore>()

        let docTreeStore =
            globalStore.CreateCVal("DocsTree", LoadingState<DocTreeNode list>.NotStartYet)

        if not docTreeStore.Value.IsLoadingNow && docTreeStore.Value.Value.IsNone then
            docTreeStore.Publish LoadingState.Loading
            hook.GetHttpString("Docs/index.json")
            |> hook.RenderCall(Option.bind hook.ParseJson<DocTreeNode list> >> LoadingState.ofOption >> docTreeStore.Publish)

        docTreeStore :> aval<_>


    /// Get docs segement and save it to global store
    member hook.GetOrLoadDocHtml(lang: string, key: string, query) =
        let globalStore = hook.ServiceProvider.GetMultipleServices<IGlobalStore>()

        let htmlStore =
            globalStore.CreateCVal("docs-html-" + lang + "-" + key, LoadingState<string>.NotStartYet)

        if not htmlStore.Value.IsLoadingNow && htmlStore.Value.Value.IsNone then
            htmlStore.Publish LoadingState.start
            hook.GetHttpString("Docs/" + key + "?" + query)
            |> hook.RenderCall(LoadingState.ofOption >> htmlStore.Publish)

        htmlStore :> aval<_>


    /// Get demo source code and save it to global store
    member hook.GetOrLoadDemoCodeHtml(source: string) =
        let globalStore = hook.ServiceProvider.GetMultipleServices<IGlobalStore>()

        let sourceStore =
            globalStore.CreateCVal("demo-source-" + source, LoadingState<string>.NotStartYet)

        if not sourceStore.Value.IsLoadingNow && sourceStore.Value.Value.IsNone then
            sourceStore.Publish LoadingState.Loading
            hook.GetHttpString(source) |> hook.RenderCall(LoadingState.ofOption >> sourceStore.Publish)

        sourceStore :> aval<_>
