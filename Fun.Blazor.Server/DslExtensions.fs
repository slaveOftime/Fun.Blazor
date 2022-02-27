namespace Fun.Blazor

open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Mvc.Rendering
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


[<AutoOpen>]
module FunBlazorServerExtensions =

    /// With this, we can generate markup for different RenderMode.
    let rootComp<'T when 'T :> IComponent> (ctx: HttpContext) (renderMode: RenderMode) =
        let result = ctx.RenderFragment(typeof<'T>, renderMode).Result

        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, result)
            index + 1
        )


    /// Apply style text to a apecific style tag in the end of html body to override other style
    /// This is supposed to be used for hot-reload
    let hotReloadJSInterop =
        js """
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
