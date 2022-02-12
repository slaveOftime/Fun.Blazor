[<AutoOpen>]
module Fun.Blazor.FelizDsl

open System
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing


type FunBlazorSvgEngine(mk, ofStr, empty) =
    inherit Feliz.SvgEngine<NodeRenderFragment>(mk, ofStr, empty)


type html with

    static member route(render: string list -> NodeRenderFragment) =
        html.inject (fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
            let location = hook.UseStore nav.Uri

            hook.OnFirstAfterRender.Add(fun () ->
                interception.EnableNavigationInterceptionAsync() |> ignore
                nav.LocationChanged.Subscribe(fun e ->
                    try
                        location.Publish e.Location
                    with
                        | _ -> ()
                )
                |> hook.AddDispose
            )

            html.watch (location, (fun loc -> RouterUtils.urlSegments (Uri loc).PathAndQuery RouteMode.Path |> render))
        )


let svg =
    FunBlazorSvgEngine((fun tag nodes -> EltWithChildBuilder tag { yield! nodes }), html.text, Internal.emptyNode)

let attr =
    FunBlazorAttrEngine((fun k v -> k => v), (fun k v -> if v then k => null else Internal.emptyAttr()))

let style = Feliz.CssEngine(fun k v -> k, v)
