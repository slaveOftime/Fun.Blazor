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
