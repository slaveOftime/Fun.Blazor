﻿// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Nav

open System
open FSharp.Data.Adaptive
open MudBlazor
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Router
open Fun.Blazor.Docs.Controls
open Fun.Blazor.Docs.Wasm


let private docsSeg = "Docs"
let private docsSegUrl = docsSeg + "/"


let navmenu =
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
                                childContent [|
                                    for doc in docs do
                                        MudNavLink'' {
                                            Href(path + "/" + sanitizeFileName doc.Name)
                                            getDocName doc
                                        }
                                    buildDocMenuTree langStr path childs
                                |]
                            }
                        | DocTreeNode.Doc doc ->
                            let docName = getDocName doc
                            MudNavLink'' {
                                Href(path + "/" + sanitizeFileName doc.Name)
                                MudText'' {
                                    Typo Typo.``inherit``
                                    Color(
                                        if docName = "Get Started" || docName = "入门指南" then
                                            Color.Success
                                        else
                                            Color.Default
                                    )
                                    docName
                                }
                            }
                }


            div {
                style {
                    height "100%"
                    displayFlex
                    flexDirectionColumn
                    overflowHidden
                }
                childContent [|
                    spaceV3
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
                |]
            }
    )


let docRouting (docs: DocTreeNode list) : Router<NodeRenderFragment> =
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
