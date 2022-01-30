[<AutoOpen>]
module Fun.Blazor.DslRouting

open System
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing
open Fun.Blazor.Router


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


    static member route(routes: Router<NodeRenderFragment> list) =
        html.inject (fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
            let location = hook.UseStore (Uri nav.Uri).PathAndQuery

            hook.OnFirstAfterRender.Add(fun () ->
                interception.EnableNavigationInterceptionAsync() |> ignore
                nav.LocationChanged.Subscribe(fun e ->
                    try
                        location.Publish (Uri e.Location).PathAndQuery
                    with
                        | _ -> ()
                )
                |> hook.AddDispose
            )

            html.watch (location, choose routes >> Option.defaultValue emptyRender)
        )
