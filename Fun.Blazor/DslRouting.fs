[<AutoOpen>]
module Fun.Blazor.DslRouting

open System
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing
open Fun.Blazor.Router
open Bolero


type html with

    static member route (render: string list -> Node) = html.inject (fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
        let location = hook.UseStore nav.Uri

        hook.OnFirstAfterRender.Subscribe (fun () ->
            interception.EnableNavigationInterceptionAsync() |> ignore
            nav.LocationChanged.Subscribe (fun e -> try location.Publish e.Location with _ -> ()) |> hook.AddDispose
        )
        |> hook.AddDispose

        html.watch (location, fun loc ->
            RouterUtils.urlSegments (Uri loc).PathAndQuery RouteMode.Path
            |> render
        ))

    static member route (routes: Router<Node> list) = html.inject (fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
        let location = hook.UseStore (Uri nav.Uri).PathAndQuery

        hook.OnFirstAfterRender.Subscribe (fun () ->
            interception.EnableNavigationInterceptionAsync() |> ignore
            nav.LocationChanged.Subscribe (fun e -> try location.Publish (Uri e.Location).PathAndQuery with _ -> ()) |> hook.AddDispose
        )
        |> hook.AddDispose

        html.watch (location, choose routes >> Option.defaultValue html.none))
