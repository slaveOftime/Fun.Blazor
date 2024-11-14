[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Routes

open System
open MudBlazor
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Router
open Fun.Blazor.Docs.Controls.BasicControls
open Fun.Blazor.Docs.Wasm


let private docRouting (docs: DocTreeNode list) : Router<NodeRenderFragment> =
    fun url ->
        let startIndex = url.IndexOf(docsSegUrl, StringComparison.OrdinalIgnoreCase)

        if startIndex < 0 then
            None
        else
            let endIndex = url.IndexOf "?"

            let path =
                if endIndex = -1 then
                    url.Substring(startIndex + docsSegUrl.Length)
                else
                    url.Substring(startIndex + docsSegUrl.Length, endIndex - startIndex - docsSegUrl.Length)

            path.Split("/")
            |> Seq.map (fun x -> x.Trim())
            |> Seq.filter ((<>) "")
            |> Seq.toList
            |> findDoc docs
            |> Option.map docView


let routes =
    html.injectWithNoKey (fun (hook: IComponentHook) -> adapt {
        match! hook.GetOrLoadDocsTree() with
        | LoadingState.NotStartYet -> notFound
        | LoadingState.Loading -> MudProgressLinear'.create ()
        | LoadingState.Loaded docs
        | LoadingState.Reloading docs ->
            let routes = [ routeCi "/" home; docRouting docs; Demos.GiraffeStyleRouter.demoRouting ]
            html.route (
                docs,
                [|
                    // For host on slaveoftime.fun server mode
                    yield! routes
                    // For host on github-pages WASM mode
                    subRouteCi "/Fun.Blazor.Docs" routes
                    routeAny (
                        docs
                        |> Seq.tryHead
                        |> Option.map (
                            function
                            | DocTreeNode.Category(doc, _, _)
                            | DocTreeNode.Doc doc -> docView doc
                        )
                        |> Option.defaultValue notFound
                    )
                |]
            )
    })
