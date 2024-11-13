// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DocView

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.JSInterop
open Fun.Result
open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Controls
open Fun.Blazor.Docs.Wasm


let docView (doc: DocBrief) =
    html.inject (
        doc,
        fun (hook: IComponentHook, js: IJSRuntime) ->
            let isOpen = hook.ShareStore.CreateCVal("IsDocDrawerOpen", true)
            let docSegmentLoadedCount = cval 0

            let mutable isCodeHighlighted = false


            let segementsBundle = adaptive {
                let! lang = hook.Lang

                let segments =
                    doc.LangSegments
                    |> Map.tryFind lang
                    |> function
                        | None -> doc.LangSegments |> Map.tryFind "en"
                        | Some x -> Some x
                    |> Option.defaultValue []

                let langStr = if doc.LangSegments |> Map.containsKey lang then lang else "en"

                let docSegmentsCount =
                    segments
                    |> Seq.filter (
                        function
                        | Segment.Html _ -> true
                        | _ -> false
                    )
                    |> Seq.length


                hook.SetPrerenderStore(fun _ ->
                    for segment in segments do
                        match segment with
                        | Segment.Html key -> hook.SetDataToPrerenderStore(hook.MakeDocHtmlKey(langStr, key), hook.DocHtml(langStr, key).Value)
                        | _ -> ()
                )

                return segments, docSegmentsCount, langStr
            }

            let shouldHighlightCode = adaptive {
                let! _, docSegmentsCount, _ = segementsBundle
                let! x = docSegmentLoadedCount
                return x >= docSegmentsCount && not isCodeHighlighted
            }


            let menuBtn = adapt {
                let! isOpen, setIsOpen = isOpen.WithSetter()
                MudIconButton'' {
                    Icon Icons.Material.Filled.Menu
                    Color Color.Inherit
                    Edge Edge.Start
                    OnClick(fun _ -> setIsOpen (not isOpen))
                }
            }

            let drawer = adapt {
                let! binding = isOpen.WithSetter()
                MudDrawer'' {
                    Open' binding
                    Elevation 25
                    ClipMode DrawerClipMode.Always
                    docNavmenu
                }
            }

            let langBtn = adapt {
                let! langStr, setLang = hook.Lang.WithSetter()
                MudMenu'' {
                    style { maxWidth 120 }
                    Label langStr
                    StartIcon Icons.Material.Filled.Translate
                    EndIcon Icons.Material.Filled.KeyboardArrowDown
                    MudMenuItem'' {
                        OnClick(fun _ -> setLang "en")
                        "English"
                    }
                    MudMenuItem'' {
                        OnClick(fun _ -> setLang "cn")
                        "中文"
                    }
                }
            }


            hook.OnFirstAfterRender.Add(fun () ->
                shouldHighlightCode.AddInstantCallback(
                    function
                    | true ->
                        task {
                            do! Task.Delay 100
                            do! js.highlightCode ()
                            isCodeHighlighted <- true
                        }
                        |> ignore
                    | _ -> ()
                )
                |> hook.AddDispose
            )


            MudContainer'' {
                SectionContent'' {
                    SectionName "toolbar-start"
                    menuBtn
                }
                SectionContent'' {
                    SectionName "drawer"
                    drawer
                }
                SectionContent'' {
                    SectionName "toolbar-end"
                    langBtn
                }
                adapt {
                    let! segments, _, langStr = segementsBundle
                    for segment in segments do
                        match segment with
                        | Segment.Demo key -> demos |> Map.tryFind key |> Option.map DemoView.Create |> Option.defaultValue notFound

                        | Segment.Html key -> adapt {
                            match! hook.GetOrLoadDocHtml(langStr, key, "cacheKey=" + string doc.LastModified.Ticks) with
                            | LoadingState.NotStartYet -> notFound
                            | LoadingState.Loading -> linearProgress
                            | LoadingState.Loaded docHtml
                            | LoadingState.Reloading docHtml ->
                                docSegmentLoadedCount.Publish((+) 1)
                                div {
                                    article {
                                        class' "markdown-body"
                                        html.raw docHtml
                                    }
                                }
                          }

                        spaceV4
                }
                styleElt { ruleset ".markdown-body li" { listStyleTypeInitial } }
            }
    )
