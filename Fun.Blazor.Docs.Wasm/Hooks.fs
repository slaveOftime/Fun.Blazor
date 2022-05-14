[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Hooks

open System.Net.Http
open System.Text.Json
open System.Text.Json.Serialization
open FSharp.Data.Adaptive
open Fun.Result
open Fun.Blazor


let private jsonOptions =
    let options = JsonSerializerOptions()
    options.Converters.Add(JsonFSharpConverter())
    options


let private fromJson<'T> (str: string) = JsonSerializer.Deserialize<'T>(str, jsonOptions)


type IShareStore with

    member store.IsServerSideRendering =
        store.CreateCVal(nameof store.IsServerSideRendering, false)

    member store.IsDarkMode = store.CreateCVal(nameof store.IsDarkMode, true)


type IComponentHook with

    member hook.ShareStore = hook.ServiceProvider.GetMultipleServices<IShareStore>()


    /// This is used for handle server side rendering call or async call if it is not first time rendering on server
    member hook.RenderCall map data =
        if hook.ShareStore.IsServerSideRendering.Value then
            data |> Task.runSynchronously |> map
        else
            data |> Task.map map |> ignore


    /// Get docs tree json file and save it to global store
    member hook.GetOrLoadDocsTree() =
        let globalStore, http =
            hook.ServiceProvider.GetMultipleServices<IGlobalStore * HttpClient>()

        let docTreeStore =
            globalStore.CreateCVal("DocsTree", LoadingState<DocTreeNode list>.NotStartYet)

        if not docTreeStore.Value.IsLoadingNow then
            docTreeStore.Publish LoadingState.Loading
            http.GetStringAsync("Docs/index.json")
            |> hook.RenderCall(fromJson<DocTreeNode list> >> LoadingState.Loaded >> docTreeStore.Publish)

        docTreeStore :> aval<_>


    /// Get docs segement and save it to global store
    member hook.GetOrLoadDocHtml(lang: string, key: string, query) =
        let globalStore, http =
            hook.ServiceProvider.GetMultipleServices<IGlobalStore * HttpClient>()

        let htmlStore =
            globalStore.CreateCVal("docs-html-" + lang + "-" + key, LoadingState<string>.NotStartYet)

        if htmlStore.Value.IsLoadingNow |> not then
            htmlStore.Publish LoadingState.start
            http.GetStringAsync("Docs/" + key + "?" + query)
            |> hook.RenderCall(fun data -> htmlStore.Publish(LoadingState.Loaded data))

        htmlStore :> aval<_>


    /// Get demo source code and save it to global store
    member hook.GetOrLoadDemoCodeHtml(source: string) =
        let globalStore, http =
            hook.ServiceProvider.GetMultipleServices<IGlobalStore * HttpClient>()

        let sourceStore =
            globalStore.CreateCVal("demo-source-" + source, LoadingState<string>.NotStartYet)

        if not sourceStore.Value.IsLoadingNow then
            sourceStore.Publish LoadingState.Loading
            http.GetStringAsync(source) |> hook.RenderCall(LoadingState.Loaded >> sourceStore.Publish)

        sourceStore :> aval<_>
