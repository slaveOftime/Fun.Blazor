﻿[<AutoOpen>]
module Fun.Blazor.HotReloadDsl

open Fun.Blazor
open Fun.Blazor.HotReload


type html with

    /// Default host will be "http://localhost:9025"
    static member hotReloadComp<'T>(renderFn: 'T -> NodeRenderFragment, renderEntryName: string, renderFnArg: 'T, ?host: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<HotReloadComponent<'T>>(index)
            builder.AddAttribute(index + 1, "RenderFn", renderFn)
            builder.AddAttribute(index + 2, "RenderFnArg", renderFnArg)
            builder.AddAttribute(index + 3, "RenderEntryName", renderEntryName)
            builder.AddAttribute(index + 4, "Host", defaultArg host "http://localhost:9025")
            builder.CloseComponent()
            index + 5
        )

    /// Default host will be "http://localhost:9025
    static member hotReloadComp(render: NodeRenderFragment, renderEntryName: string) =
        html.hotReloadComp ((fun () -> render), renderEntryName, ())

    /// Default host will be "http://localhost:9025
    static member hotReloadComp(render: NodeRenderFragment, renderEntryName: string, host: string) =
        html.hotReloadComp ((fun () -> render), renderEntryName, (), host = host)

    /// Apply style text to a apecific style tag in the end of html body to override other style
    /// This is supposed to be used for hot-reload
    /// * If you are using Visual Studio this should not be necessary
    static member inline hotReloadJSInterop =
        js
            """
            window.hotReloadStyle = (id, style) => {
                let ele = document.getElementById(id)
                if (ele) {
                    ele.innerText = style
                } else {
                    ele = document.createElement("style")
                    ele.id = id
                    ele.innerText = style
                    document.body.appendChild(ele)
                }
            }
        """
