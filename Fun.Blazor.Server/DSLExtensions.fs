namespace Fun.Blazor

open System
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Mvc.Rendering
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


type RootComponent() =
    inherit ComponentBase()

    [<Parameter>]
    member val ComponentType = Unchecked.defaultof<Type> with get, set

    [<Parameter>]
    member val RenderMode = RenderMode.ServerPrerendered with get, set

    [<Inject>]
    member val HttpContextAccessor = Unchecked.defaultof<IHttpContextAccessor> with get, set

    override this.BuildRenderTree(builder) =
        let body = this.HttpContextAccessor.HttpContext.RenderFragment(this.ComponentType, this.RenderMode)
        builder.AddMarkupContent(0, body.Result)


[<AutoOpen>]
module Extensions =
    open Fun.Blazor.Operators

    let rootComp<'T when 'T :> IComponent> (renderMode: RenderMode) =
        ComponentBuilder<RootComponent>() {
            "ComponentType" => typeof<'T>
            "RenderMode" => renderMode
        }
