[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Hooks

open System.Net
open System.Net.Http
open System.Text.Json
open System.Text.Json.Serialization
open FSharp.Data.Adaptive
open Microsoft.JSInterop
open Microsoft.AspNetCore.Components
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
    member hook.GlobalStore = hook.ServiceProvider.GetMultipleServices<IGlobalStore>()


    member hook.DocsTree =
        hook.GlobalStore.CreateCVal(nameof hook.DocsTree, LoadingState<DocTreeNode list>.NotStartYet)

    member _.MakeDocHtmlKey(lang: string, key: string) = "docs-html-" + lang + "-" + key

    member hook.DocHtml(lang: string, key: string) = hook.GlobalStore.CreateCVal(hook.MakeDocHtmlKey(lang, key), LoadingState<string>.NotStartYet)


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
            with ex ->
                snackbar.Add(ex.Message, Severity.Error) |> ignore
                return None
        }

    member hook.ParseJson<'T>(jsonStr: string) =
        let snackbar = hook.ServiceProvider.GetMultipleServices<ISnackbar>()
        try
            JsonSerializer.Deserialize<'T>(jsonStr, jsonOptions) |> Some
        with ex ->
            snackbar.Add(ex.Message, Severity.Error) |> ignore
            None


    member hook.GetDataFromPrerenderStore<'T>(key: string) =
        let persistentStore =
            hook.ServiceProvider.GetMultipleServices<PersistentComponentState>()

        match persistentStore.TryTakeFromJson<string>(key) with
        | true, value ->
            try
                let result = JsonSerializer.Deserialize<'T>(value, jsonOptions)
                printfn "Use persisted data successful: %s" key
                Some result
            with e ->
                printfn "Use persisted data failed: %s. Json serialization failed: %s" key e.Message
                None
        | _ ->
            printfn "Use persisted data failed: %s. Not persisted" key
            None

    member hook.SetDataToPrerenderStore<'T>(key: string, value: 'T) =
        let persistentStore =
            hook.ServiceProvider.GetMultipleServices<PersistentComponentState>()

        persistentStore.PersistAsJson(key, JsonSerializer.Serialize(value, jsonOptions))

    member hook.SetPrerenderStore(onPersistence: unit -> unit) =
        if hook.ShareStore.IsServerSideRendering.Value then
            let persistentStore =
                hook.ServiceProvider.GetMultipleServices<PersistentComponentState>()

            hook.OnInitialized.Add(fun _ -> persistentStore.RegisterOnPersisting(fun _ -> task { onPersistence () }) |> ignore)


    /// Get docs tree json file and save it to global store
    member hook.GetOrLoadDocsTree() =
        let docTreeStore = hook.DocsTree

        match hook.GetDataFromPrerenderStore<LoadingState<DocTreeNode list>> "DocsTree" with
        | Some data -> docTreeStore.Publish data
        | _ ->
            if not docTreeStore.Value.IsLoadingNow && docTreeStore.Value.Value.IsNone then
                docTreeStore.Publish LoadingState.Loading
                hook.GetHttpString("Docs/index.json")
                |> hook.RenderCall(Option.bind hook.ParseJson<DocTreeNode list> >> LoadingState.ofOption >> docTreeStore.Publish)

        docTreeStore :> aval<_>


    /// Get docs segement and save it to global store
    member hook.GetOrLoadDocHtml(lang: string, key: string, query) =
        let htmlStore = hook.DocHtml(lang, key)

        match hook.GetDataFromPrerenderStore<LoadingState<string>>(hook.MakeDocHtmlKey(lang, key)) with
        | Some data -> htmlStore.Publish data
        | _ ->
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
