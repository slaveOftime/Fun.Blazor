// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Nav

open FSharp.Data.Adaptive
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open Fun.Blazor.Docs.Wasm


let private docsSeg = "documents"
let private docsSegUrl = docsSeg + "/"


let navmenu =
    html.inject (
        "navmenu",
        fun (hook: IComponentHook) ->

            let rec buildDocMenuTree path (items: DocTreeNode list) =
                html.fragment [
                    for item in items do
                        match item with
                        | DocTreeNode.Category (indexDoc, docs, childs) ->
                            let path = path + "/" + sanitizeFileName indexDoc.Name
                            MudNavGroup'() {
                                Title indexDoc.Name
                                childContent
                                    [
                                        for doc in docs do
                                            MudNavLink'() {
                                                Href(path + "/" + sanitizeFileName doc.Name)
                                                doc.Name
                                            }
                                        buildDocMenuTree path childs
                                    ]
                            }
                        | DocTreeNode.Doc doc ->
                            MudNavLink'() {
                                Href(path + "/" + sanitizeFileName doc.Name)
                                doc.Name
                            }
                ]


            div {
                style {
                    height "100%"
                    displayFlex
                    flexDirectionColumn
                    overflowHidden
                }
                childContent [
                    spaceV3
                    div {
                        style {
                            flexGrow 1
                            overflowAuto
                        }
                        childContent [
                            adaptiview () {
                                let! tree, isLoading = hook.GetOrLoadDocsTree() |> AVal.map (LoadingState.unzip [])
                                if isLoading then MudProgressLinear'.create ()
                                MudNavMenu'() { buildDocMenuTree docsSeg tree }
                            }
                        ]
                    }
                ]
            }
    )


let docRouting (docs: DocTreeNode list) : Router<NodeRenderFragment> =
    fun url ->
        let startIndex = url.IndexOf docsSegUrl

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
