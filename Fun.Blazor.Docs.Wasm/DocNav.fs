// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Nav

open FSharp.Data.Adaptive
open MudBlazor
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Docs.Wasm


let docsSeg = "Docs"
let docsSegUrl = docsSeg + "/"


let docNavmenu =
    html.inject (
        "navmenu",
        fun (hook: IComponentHook) ->

            let rec buildDocMenuTree langStr path (items: DocTreeNode list) =
                let getDocName (doc: DocBrief) = doc.Names |> Map.tryFind langStr |> Option.defaultValue doc.Name
                fragment {
                    for item in items do
                        match item with
                        | DocTreeNode.Category(indexDoc, docs, childs) ->
                            let path = path + "/" + sanitizeFileName indexDoc.Name
                            MudNavGroup'' {
                                Title(getDocName indexDoc)
                                for doc in docs do
                                    MudNavLink'' {
                                        Href(path + "/" + sanitizeFileName doc.Name)
                                        getDocName doc
                                    }
                                buildDocMenuTree langStr path childs
                            }
                        | DocTreeNode.Doc doc ->
                            let docName = getDocName doc
                            MudNavLink'' {
                                Href(path + "/" + sanitizeFileName doc.Name)
                                docName
                            }
                }


            div {
                style {
                    height "100%"
                    displayFlex
                    flexDirectionColumn
                    overflowHidden
                    paddingTop 12
                }
                div {
                    style {
                        flexGrow 1
                        overflowAuto
                    }
                    adaptiview () {
                        let! langStr = hook.Lang
                        let! tree, isLoading = hook.GetOrLoadDocsTree() |> AVal.map (LoadingState.unzip [])
                        if isLoading then MudProgressLinear'.create ()
                        MudNavMenu'' { buildDocMenuTree langStr docsSeg tree }
                    }
                }
            }
    )
