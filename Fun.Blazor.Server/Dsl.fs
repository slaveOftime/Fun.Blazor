[<AutoOpen>]
module Fun.Blazor.FunBlazorServerDsl

open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Mvc.Rendering
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


/// With this, we can generate markup for different RenderMode.  
/// * Must be defined as a variable and use it later for SSR. Still not know why.
let rootComp<'T when 'T :> IComponent> (ctx: HttpContext) (renderMode: RenderMode) =
    let result = ctx.RenderFragment(typeof<'T>, renderMode).Result

    NodeRenderFragment(fun _ builder index ->
        builder.AddMarkupContent(index, result)
        index + 1
    )


type html with

    /// With this, we can generate markup for different RenderMode.  
    /// * Must be defined as a variable and use it later for SSR. Still not know why.
    static member rootComp<'T when 'T :> IComponent>(ctx, ?renderMode) =
        rootComp<'T> ctx (defaultArg renderMode RenderMode.ServerPrerendered)
