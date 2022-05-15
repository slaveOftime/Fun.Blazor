// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Nav

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.WebUtilities
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open Fun.Blazor.Docs.Wasm


let navmenu =
    html.inject (
        "navmenu",
        fun (hook: IComponentHook) ->

            let rec buildDocMenuTree path (items: DocTreeNode list) =
                html.fragment [
                    for item in items do
                        match item with
                        | DocTreeNode.Category (indexDoc, docs, childs) ->
                            let path = path + "/" + indexDoc.Name
                            MudNavGroup'() {
                                Title indexDoc.Name
                                childContent [
                                    for doc in docs do
                                        MudNavLink'() {
                                            Href(path + "/" + doc.Name)
                                            doc.Name
                                        }
                                    buildDocMenuTree path childs
                                ]
                            }
                        | DocTreeNode.Doc doc ->
                            MudNavLink'() {
                                Href(path + "/" + doc.Name)
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
                                MudNavMenu'() { buildDocMenuTree "?doc=" tree }
                            }
                        ]
                    }
                ]
            }
    )


let docRouting (docs: DocTreeNode list) : Router<NodeRenderFragment> =
    fun url ->
        let index = url.IndexOf "?"
        if index = -1 then
            None
        else
            let quries = QueryHelpers.ParseNullableQuery(url.Substring(index + 1))
            match quries.TryGetValue "doc" with
            | false, _ -> None
            | true, path ->
                path.ToString().Split("/")
                |> Seq.map (fun x -> x.Trim())
                |> Seq.filter ((<>) "")
                |> Seq.toList
                |> findDoc docs
                |> Option.map docView
